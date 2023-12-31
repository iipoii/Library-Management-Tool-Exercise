### 图书管理工具

项目基于.NETCore 6.0, 使用C#进行开发，用于辅助管理图书馆数据库。

若要获取完整功能，请修改config目录下的json文件。

#### 1. 运行方式：
如果只需要测试程序功能，运行本项目该路径下的程序 .\MyForm\bin\Debug\net6.0-windows\MyForm.exe 或者 .\MyForm\bin\Release\net6.0-windows\MyForm.exe

测试模式下，程序通过对TemporaryDatabase中提供的静态DataSet对象随即添加数据，创建一个测试用数据库。

#### 2. 测试模式
测试模式在登录或注册界面进行勾选，非测试模式需要修改config目录下的SQLConnect_config.json，提供数据库连接字符串。

##### 测试账号：
提供管理员测试账号 &emsp; 账号：adminUser &emsp; 密码：adminPWD
提供游客测试账号   &emsp; 账号：guestUser &emsp; 密码：guestPWD
用户也可以通过邮箱验证的方式注册游客账号，注册时需要联网环境，若要获取通过邮箱验证的注册功能，需要修改config目录下的SMTP_config.json，其中smtpServer为服务器地址，from为邮箱地址，password为邮箱的smtp服务授权码。

##### 运行方式：
如果只需要测试程序功能，运行本项目该路径下的程序 .\MyForm\bin\Debug\net6.0-windows\MyForm.exe 或者 .\MyForm\bin\Release\net6.0-windows\MyForm.exe

测试模式下，程序通过TemporaryDatabase类创建一个临时的测试用数据库，随后添加一些测试数据。


#### 3. 非测试模式
非测试模式需要修改config目录下的SQLConnect_config.json中的Connect_string，即数据库连接字符串。

非测试模式下，本程序采用非链接模式与数据库进行交互，即程序启动时，通过TemporaryDatabase类自动创建一个数据库，读取数据库服务器的表数据和表结构，在进行数据更改后再同步到服务器中。

运行在非测试模式时，请注意修改程序中的表名，与服务器数据库中的表名保持一致。

#### 4. 功能说明

##### 登录界面
在登录界面输入正确的用户名和密码后，单机登录键即可登录进入服务界面。程序会判断用户为游客权限还是管理员权限，从而进入不同的服务界面。在登陆界面需要选择是否使用测试模式，若选择测试模式，请使用提供的测试账号，非测试模式需要数据库中提供相应的表。

在登录界面也可单击注册键，进入注册界面。

##### 注册界面（需在联网环境）
注册时需要先输入正确的邮箱，单击获取验证码键获取包含验证码的邮件，在注册界面输入正确的用户名、密码、邮箱、验证码后，单击注册键即可注册成功。
在注册界面需要选择是否使用测试模式，以判断是否将注册账号添加到数据库服务器中。

##### 管理员服务界面

采用多文档界面，即MDI（Multiple-Document Interface），在菜单栏可以选择服务窗口，目前提供以下服务：
1. 图书信息编辑
2. 图书借阅记录编辑

##### 游客服务界面

同样采用多文档界面，在菜单栏可以选择服务窗口，目前提供以下服务：
1. 查询当前借阅
2. 登记借阅图书信息
3. 登记归还图书信息
4. 查询馆藏图书（在菜单栏 ```更多>>``` 中）
5. 修改密码（在菜单栏 ```更多>>``` 中）