using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Newtonsoft.Json;
using System.Data.SqlClient;


namespace MyForm.Class
{
    internal class TemporaryDatabase
    {
        public static DataSet dataSet = new DataSet();
        public static Boolean test_mode = true;
        private class SQLConneSettings
        {
            // 请确保与json文件中属性名一致
            public string DataSource { get; set; }
            public string InitialCatalog { get; set; }
            public string UserID { get; set; }
            public string Password { get; set; }
            // 仅使用到了Connect_string
            public string Connect_string { get; set; }
        }

        public static void InitializeDataSet()
        {
            dataSet = new DataSet();
        }

        public static void ClearDataSet()
        {
            dataSet.Clear();
        }

        // 从json文件中读取连接参数
        private static SQLConneSettings ReadSQLConneSettingsFromJson()
        {
            SQLConneSettings settings = new SQLConneSettings();
            
            try
            {
                // string jsonFilePath = "path_to_your_json_file.json";
                string jsonFilePath = "C:\\Users\\lenovo\\OneDrive\\桌面\\shiyan\\winform\\MyForm\\MyForm\\config\\SQLConnect_config.json";
                string jsonContent = File.ReadAllText(jsonFilePath);
                settings = JsonConvert.DeserializeObject<SQLConneSettings>(jsonContent);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "读取数据库连接参数文件出现错误");
            }

            return settings;
        }

        // 在本地临时数据库创建空白表
        public static void CreateTable(string tableName)
        {
            DataTable table = new DataTable(tableName);
            dataSet.Tables.Add(table);
        }


        // 从数据库添加表到本地临时数据库
        public static void GetTable(string tableName)
        {
            SQLConneSettings settings = ReadSQLConneSettingsFromJson();
            // 创建连接字符串
            string connectionString = settings.Connect_string;
            // 创建查询字符串
            string queryString = string.Format("SELECT * FROM {0}", tableName);

            // 创建连接对象和DataAdapter对象
            try 
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // 创建空白表
                    CreateTable(tableName);

                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);
                    // 填充数据到DataSet
                    adapter.FillSchema(dataSet, SchemaType.Source, tableName);
                    adapter.Fill(dataSet, tableName);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "从数据库填充数据失败");
            }
        }

        // 提交修改到数据库
        public static void UpdateTable(string tableName)
        {
            SQLConneSettings settings = ReadSQLConneSettingsFromJson();
            // 创建连接字符串
            string connectionString = settings.Connect_string;
            // 创建查询字符串
            string queryString = string.Format("SELECT * FROM {0}", tableName);

            // 创建连接对象和DataAdapter对象
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);

                    // 创建SqlCommandBuilder对象
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                    // 设置自动生成的更新命令
                    adapter.UpdateCommand = builder.GetUpdateCommand();
                    adapter.InsertCommand = builder.GetInsertCommand();
                    adapter.DeleteCommand = builder.GetDeleteCommand();

                    // 提交修改
                    adapter.Update(dataSet, tableName);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "提交修改失败");
            }
        }

        public static void AddColumn(string tableName, string columnName, Type dataType)
        {
            DataTable table = dataSet.Tables[tableName];
            table.Columns.Add(columnName, dataType);
        }

        // 增加行数据
        // 传入参数为:1.表名 2.各列数据
        public static void AddRow(string tableName, params object[] values)
        {
            // 该方法只适用于表中含有自增主列的情况
            // 即若表有i+1列，则输入数据应该为i维
            DataTable table = dataSet.Tables[tableName];
            if (values.Length + 1 != table.Columns.Count)
            {
                // 处理长度不匹配的情况，进行抛出异常，输入列应不包含自增主键列
                throw new ArgumentException("Values array length does not match the number of columns in the table.");
            }
            DataRow newRow = table.NewRow();
            int para_index = 0;
            // 遍历表中各列，避免为自增主键列赋值
            foreach (DataColumn column in table.Columns)
            {
                // 检查当前列是否是自增主键列
                if (column.AutoIncrement || column.ColumnName == "ID")
                {
                    // 自增主键列不需要赋值
                    continue;
                }
                // 根据列名查找对应的值
                string columnName = column.ColumnName;
                newRow[columnName] = values[para_index];
                para_index++;

            }
            // 将新行添加到表格中
            table.Rows.Add(newRow);
            // 非测试模式提交修改
            if (!test_mode)
            {
                UpdateTable(tableName);
            }
        }

        // 修改行数据
        public static void UpdateRow(string tableName, Func<DataRow, bool> condition, Action<DataRow> updateAction)
        {
            DataTable table = dataSet.Tables[tableName];
            var query = table.AsEnumerable().Where(condition);
            foreach (var row in query)
            {
                updateAction(row);
            }
            if (!test_mode)
            {
                UpdateTable(tableName);
            }
            // 非测试模式提交修改
            if (!test_mode)
            {
                UpdateTable(tableName);
            }
        }

        //删除行数据
        public static void DeleteRow(string tableName, Func<DataRow, bool> condition)
        {
            DataTable table = dataSet.Tables[tableName];
            var rowsToDelete = table.AsEnumerable().Where(condition).ToArray();
            foreach (var row in rowsToDelete)
            {
                table.Rows.Remove(row);
            }
            // 非测试模式提交修改
            if (!test_mode)
            {
                UpdateTable(tableName);
            }
        }

        public static void PrintTable(string tableName)
        {
            DataTable table = dataSet.Tables[tableName];
            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                {
                    Console.WriteLine(column.ColumnName + ": " + row[column]);
                }
                Console.WriteLine();
            }
        }

        // 简便起见，以下的测试表中没有添加外键约束
         public static void CreateTestTableAccount()
        {
            // 添加账号表
            DataTable account_table = new DataTable("账号表");
            dataSet.Tables.Add(account_table);
            // 添加列
            AddColumn("账号表", "ID", typeof(short));
            AddColumn("账号表", "username", typeof(string));
            AddColumn("账号表", "password", typeof(string));
            AddColumn("账号表", "type", typeof(string));
            // 添加自增主键
            account_table.Columns["ID"].AutoIncrement = true;  // 将CustomerID列设置为自增主键
            account_table.Columns["ID"].AutoIncrementSeed = 1; // 设置自增种子值
            account_table.Columns["ID"].AutoIncrementStep = 1; // 设置自增步长
            // 添加约束
            UniqueConstraint UniqueUsernameConstraint = new UniqueConstraint("UniqueUsernameConstraint", account_table.Columns["username"]);
            account_table.Constraints.Add(UniqueUsernameConstraint);
            // 添加行
            AddRow("账号表", "adminUser", "adminPWD", "admin");
            AddRow("账号表", "guestUser", "guestPWD", "guest");
        }

        public static void CreateTestTableGuestInfo()
        {
            // 创建图书借阅记录表
            DataTable bookBorrowTable = new DataTable("图书借阅记录表");
            dataSet.Tables.Add(bookBorrowTable);
            // 添加列
            AddColumn("图书借阅记录表", "ID", typeof(int));
            AddColumn("图书借阅记录表", "书名", typeof(string));
            AddColumn("图书借阅记录表", "借阅人", typeof(string));
            AddColumn("图书借阅记录表", "借阅日期", typeof(string));
            // 添加自增主键
            bookBorrowTable.Columns["ID"].AutoIncrement = true; // 将CustomerID列设置为自增主键
            bookBorrowTable.Columns["ID"].AutoIncrementSeed = 1; // 设置自增种子值
            bookBorrowTable.Columns["ID"].AutoIncrementStep = 1; // 设置自增步长
            // 添加约束, 避免重复借阅
            // 通过设置（书名、借阅人）二元组的唯一性来实现....（可优化为（借阅人，书ID）的二元组）
            UniqueConstraint UniqueBooknameConstraint = new UniqueConstraint("UniqueUsernameConstraint", new DataColumn[] { bookBorrowTable.Columns["书名"], bookBorrowTable.Columns["借阅人"] });
            bookBorrowTable.Constraints.Add(UniqueBooknameConstraint);
            // 添加行
            for (int i = 1; i <= 5; i++)
            {
                // 随机添加几行数据
                Random random = new Random();
                AddRow("图书借阅记录表", "图书" + i.ToString(), "guestUser", DateTime.Now.AddDays(random.Next(-30, -7)).ToString());
            }
        }

        public static void CreateTestTableBook()
        {
            // 添加图书表
            DataTable bookTable = new DataTable("图书表");
            dataSet.Tables.Add(bookTable);
            // 添加列
            AddColumn("图书表", "ID", typeof(int));
            AddColumn("图书表", "书名", typeof(string));
            AddColumn("图书表", "作者", typeof(string));
            AddColumn("图书表", "出版日期", typeof(string));
            AddColumn("图书表", "ISBN", typeof(string));
            // 添加自增主键
            bookTable.Columns["ID"].AutoIncrement = true;
            bookTable.Columns["ID"].AutoIncrementSeed = 1;
            bookTable.Columns["ID"].AutoIncrementStep = 1;
            // 添加行
            AddRow("图书表", "aaa", "作者1", DateTime.Now.ToString(), "ISBN1");
            AddRow("图书表", "bbb", "作者2", DateTime.Now.ToString(), "ISBN2");
            AddRow("图书表", "ccc", "作者3", DateTime.Now.ToString(), "ISBN3");
            AddRow("图书表", "ddd", "作者4", DateTime.Now.ToString(), "ISBN4");
        }

        public static DataTable SearchInTableByCondition(string tableName, Func<DataRow, bool> condition)
        {
            DataTable search_result = new DataTable();
            // 使用Linq查询
            var query_result = dataSet.Tables[tableName]
                                      .AsEnumerable()
                                      .Where(condition)
                                      .ToList(); // 转换为 List 避免多次迭代
            //使用Any()方法检查是否有匹配项
            if (query_result.Any())
            {
                // 创建一个新表，其结构与query_result的结构匹配
                search_result = query_result.First().Table.Clone();
                // 将query_result的数据复制到新表
                foreach (DataRow row in query_result)
                {
                    search_result.ImportRow(row);
                }
            }

            return search_result;
        }

    }
}
