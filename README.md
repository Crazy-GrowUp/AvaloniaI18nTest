# AvaloniaI18nTest

## 0.项目新建 Properties 文件夹

![image-20250220094054262](.\MDImg\image-20250220094054262.png)

对应的项目配置文件里面就会增加 `<Folder Include="Properties\" />`

![image-20250220094112240](MDImg\image-20250220094112240.png)

## 1.项目添加新建项目

在 Properties 里面添加资源文件，命名为 `Resource.resx`

![image-20250220093754835](MDImg\image-20250220093754835.png)



![image-20250220094338964](MDImg\image-20250220094338964.png)

## 2.将自定义工具设置为 PublicResXFileCodeGenerator（重要）

右键 `Resource.resx` 文件，打开属性，修改属性中自定义工具为 `PublicResXFileCodeGenerator`

![image-20250220094546955](MDImg\image-20250220094546955.png)



## 3.添加文本资源

![image-20250220094833052](MDImg\image-20250220094833052.png)

![image-20250220094914081](MDImg\image-20250220094914081.png)

## 4.安装扩展 ResXManager（推荐）

安装完成后，可能需要重启VS

![image-20250220095152701](MDImg\image-20250220095152701.png)

## 5.添加多国语音

方式一：右键 `Resource.resx` 使用 ResXManager 打开

![image-20250220095522637](MDImg\image-20250220095522637.png)

![image-20250220095540530](MDImg\image-20250220095540530.png)

![image-20250220095623226](MDImg\image-20250220095623226.png)

Properties 文件夹下面就多了一个 ` Resource.en.resx `

![image-20250220095634702](MDImg\image-20250220095634702.png)

方式二：手动添加多国语言文件

比如我们要添加中文，那么就新建 `Resource.zh.resx` 资源文件

![image-20250220100055335](MDImg\image-20250220100055335.png)

然后将对应的翻译填写到资源文件中

![image-20250220100158310](MDImg\image-20250220100158310.png)



## 6.在 .axaml 文件中使用

1. 在 MainWindow.axaml 中加上 `xmlns:prop="using:AvaloniaI18nTest.Properties"`
2. 通过 `{x:Static prop:Resource.Name}` 进行使用

![image-20250220100657352](MDImg\image-20250220100657352.png)



## 7.在代码中使用

1. 在 MainWindowViewModel 中 使用 `using AvaloniaI18nTest.Properties;` 或者 `using prop = AvaloniaI18nTest.Properties;`

2. 取出其中的值

   ```c#
    public string ResxName { get; } = Resource.Name;
    public string ResxName2 { get; } = prop.Resource.Name;   
   ```



![image-20250220101304256](MDImg\image-20250220101304256.png)

3. 在 axaml 中显示

   ![image-20250220101619446](MDImg\image-20250220101619446.png)

## 8.切换语言

切换需要需要在 App.axaml.cs 中的 Initialize() 方法中进行设置

![image-20250220101923328](MDImg\image-20250220101923328.png)

```c#
 // 不写或者为空就是默认系统语言
 // Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(""); 
 // 修改语言
 // Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh"); 
 Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
```


