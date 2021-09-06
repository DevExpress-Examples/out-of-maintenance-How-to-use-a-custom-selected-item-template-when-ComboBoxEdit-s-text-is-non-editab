<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128644654/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1978)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to use a custom selected item template when ComboBoxEdit's text is non-editable


<p>The following example shows how to customize the in-place combo box editor's appearance when its text field is not editable.</p>
<p>In this example, in-place combo boxes are used to edit the 'Access Card Color' column field values. The appearance of the editors' items on the drop-down list is specified via the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.LookUpEditSettingsBase.ItemTemplate.property">ItemTemplate</a> property. As for the edit box, you can either apply the same template by setting the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.LookUpEditSettingsBase.ApplyItemTemplateToSelectedItem.property">ApplyItemTemplateToSelectedItem</a> property to <strong>true</strong> or specify another template using the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.TextEditSettings.EditNonEditableTemplate.property">EditNonEditableTemplate</a> property (in this example, we used the second approach).</p>

<br/>


