# Element-WPF
这是一个WPF版的element前端UI样式库

![element logo](https://element-plus.gitee.io/images/element-plus-logo.svg)

# 下面作废

## Usage

Step 1: 添加LayUI.Wpf Nuget包;

```Install-Package LayUI.Wpf```

Step 2: 添加代码在 App.xaml 下面:
```XML
<Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="pack://application:,,,/LayUI.Wpf;component/Themes/Default.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
</Application.Resources>
```

Step 3: 在目标页面添加需要的控件引用:
`xmlns:Lay="clr-namespace:LayUI.Wpf.Controls;assembly=LayUI.Wpf"`

Step 4: 完成
