﻿Public Interface IIndicator

    Property MinimumValue As Double

    Property MaximumValue As Double

    Property SelectedObject As ISimulationObject

    Property SelectedProperty As String

    Property SelectedPropertyType As Enums.UnitOfMeasure

    Property SelectedPropertyUnits As String

    Property DecimalDigits As Integer

    Property IntegralDigits As Integer

End Interface