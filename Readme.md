# How to customize the appearance of the in-place combo box editor


<p>The following example shows how to customize the in-place combo box editor's appearance when its text field is not editable.</p>
<p>In this example, in-place combo boxes are used to edit the 'Access Card Color' column field values. The appearance of the editors' items on the drop-down list is specified via the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.LookUpEditSettingsBase.ItemTemplate.property">ItemTemplate</a> property. As for the edit box, you can either apply the same template by setting the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.LookUpEditSettingsBase.ApplyItemTemplateToSelectedItem.property">ApplyItemTemplateToSelectedItem</a> property to <strong>true</strong> or specify another template using the <a href="https://documentation.devexpress.com/WPF/DevExpress.Xpf.Editors.Settings.TextEditSettings.EditNonEditableTemplate.property">EditNonEditableTemplate</a> property (in this example, we used the second approach).</p>

<br/>


