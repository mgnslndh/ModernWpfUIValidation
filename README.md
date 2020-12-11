# ModernWpfUIValidation

Showcasing potential bug in ModernWpf regarding error validation

## Potential bug

It seems that a simple error validation template does not work when the ModernWpfUI styles are enabled.

```xml
<Application
    x:Class="ModernWpfUIValidation.App"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:ui="http://schemas.modernwpf.com/2019"
    StartupUri="MainWindow.xaml">
    <Application.Resources>
        <ResourceDictionary>
            <!--
                Include the merged dictionaries to enable ModernWpfUI
                styling and show the potential bug
            -->
            <!--
            <ResourceDictionary.MergedDictionaries>
                <ui:ThemeResources />
                <ui:XamlControlsResources />
            </ResourceDictionary.MergedDictionaries>
            -->
        </ResourceDictionary>
    </Application.Resources>
</Application>
```