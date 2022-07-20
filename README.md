<h1><center>图像保存控件（CC_ImageSave）v0.9.3.0</center></h1>
#概述
---
1. CC_ImageSave是在.Net Framework上编写的图像保存控件，其中包含图片保存、图片删除等功能。  
2. 本版本的CC_ImageSave在图像保存时使用了Cognex VisionPro的ImageFileTool工具，在删除图片功能中使用SQLite存放曾经保存过的图片的路径。
3. 此控件主要由<b>实际做保存和删除工作的类部分</b>和<b>主要用于界面显示的UI部分</b>这两个部分组成，所以在实际使用中，需要设定类的一个UI属性为你实际使用的一个UI控件。

#接口
---
##属性
序号	|属性名称|类型|作用
-|-|-|-
1|IsNeedSafeguard|Boolean|用于设定是否需要内部保存图片队列保护，True为需要保护（队列长度有限，当队列超长时，会抛弃新需要保存的图片，默认长度15），False为不需要保护（队列长度无限）
2|IsUseCognexdll|Boolean|设定是否使用cognex的保存图片方法，此版本必须为True
3|QueueCount|Integer|图像队列长度，方便用户查看
4|SaveImageErrorTimes|Integer|显示保存图像时发生过多少次错误，比如当队列长度被保护时抛弃过多少次图片
5|SaveImageTimeInterval|Integer|设定保存图像时，扫描图像队列的间隔时间
6|SaveImageUI|ChuangChi.CC_ImageSaveUI|设定此保存图像类的UI控件，如果未设定控件，大量保存图像的参数无法被设置，可能导致保存图像失败
##方法
序号	|方法名称|参数|返回值|作用
-|-|-|-|-
1|New|-|-|初始化SaveImge类
2|SaveImage（Image，Name，ReelNumber）|Image （ICogImage） 必选，要保存的图片<br>Name（string） 可选，需要保存的图片名称<br>ReelNumber（string） 可选，需要保存的图片的序列号，此会生成一个独立文件夹|string|保存图像，图像为cognex ICogimage类型
3|Shutdown|-|-|关闭保存图像线程，并结束所有工作

#示例
###基本使用方法：
1. 引用dll：  
`Imports ChuangChi.CC_ImageSave`
2. 定义并初始化一个CC_ImageSave类：  
`Private myImagesave As ChuangChi.CC_ImageSave = New ChuangChi.CC_ImageSave`
3. 设定UI：  
`Friend WithEvents CC_ImageSaveUI1 As ChuangChi.CC_ImageSaveUI`  
`myImagesave.SaveImageUI = CC_ImageSaveUI1`
4. 传入图像并保存:  
`Private myimage As ICogImage`  
` myImagesave.SaveImage(myimage, Now.ToString("yyyy-MM-dd HH-mm-ss-fff"), "test1")`


