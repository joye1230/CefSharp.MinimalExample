这是趣蛙网络的狼人杀项目，使用了CefSharp框架作为浏览器 charom47版本
=======================



WinForms
这里放了客户端主程序，打开后直接编译即可
皮肤文件为 wolf_kill.ssk，使用IrisSkin4.dll调用的
需要编辑皮肤文件，请使用tools里面的irisskin_setup_chs.zip对皮肤进行编辑

打包
wolfkill为打包使用目录
根据VS的版本，以下目录可能会有不同请选择当前VS的目录
1.打包fameworlk
fameworlk
tools/fameworlk4.0文件放入到
C:\Program Files (x86)\Microsoft Visual Studio 14.0\SDK\Bootstrapper\Packages\DotNetFX40
fameworlk中文语言包
tools/dotNetFx40LP_Full_x86_x64zh-Hans.exe
C:\Program Files (x86)\Microsoft Visual Studio 14.0\SDK\Bootstrapper\Packages\DotNetFX40\zh-Hans

2.打包VC20014++库
如果VS已经有VC2013++选项就不用生成，如果没有覆盖上VS默认的
tools/vcredist_x86目录覆盖
C:\Program Files (x86)\Microsoft Visual Studio 14.0\SDK\Bootstrapper\Packages
