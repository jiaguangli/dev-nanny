# dev-nanny
A developer's nanny



## 结构职责

Core 负责定义整个项目中共用的一些文件和依赖

App 负责主要业务的编写

Host 负责将App业务映射为WebApi 包括modules中的App

BlazorWasm 负责页面的开发



App.Ftp 负责Ftp 相关模块的编写

App.Nginx 负责Nginx相关模块的编写





## 结构说明

```
-src				// The framwork core Code
--Dev.Core 			// Core
--Dev.App   		// Base Service
--Dev.Host  		// Api Service
--Dev.BlazorWasm  	// Web Page, base on BlazorWebAssmely

-modules			// The other service modules
--App.Nginx			// The Nginx module
--App.Ftp 			// The ftp module
```

