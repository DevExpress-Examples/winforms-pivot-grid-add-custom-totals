<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578344/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2135)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Pivot Grid for WPF - Add Custom Totals

The following example demonstrates how to add custom totals for a particular Pivot Grid field:

![Pivot Grid](./image/pivotgrid.png)

## Examle Overview

In this example, four different totals are added for the _Category Name_ row field: Average, Sum, Min, and Max. For this, add the `PivotGridCustomTotal` objects to the [PivotGridField.CustomTotals](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridField.CustomTotals?p=netframework) collection and set the [PivotGridField.TotalsVisibility](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridField.TotalsVisibility?p=netframework) property to `FieldTotalsVisibility.CustomTotals`.

## Files to Review

* [MainWindow.xaml](./CS/HowToAddCustomTotals/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/HowToAddCustomTotals/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/HowToAddCustomTotals/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/HowToAddCustomTotals/MainWindow.xaml.vb))

## Documentation

- [Totals](https://docs.devexpress.com/WPF/8057/controls-and-libraries/pivot-grid/data-shaping/aggregation/totals?p=netframework)



<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-pivot-grid-add-custom-totals&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-pivot-grid-add-custom-totals&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
