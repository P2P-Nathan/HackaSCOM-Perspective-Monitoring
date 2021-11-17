param($Uri, $Method, $Format, $ValuePath, $PostBody)

$api = New-Object -comObject "MOM.ScriptAPI"
$api.LogScriptEvent('GetRestReading.ps1', 3452, 0, "Performing API call for $Uri, format of $Format");

$resultBag = $api.CreatePropertyBag()
try {
	[System.Net.ServicePointManager]::SecurityProtocol = [System.Net.SecurityProtocolType]::Tls12
	if($Method -eq "POST")
	{
		$measurement = Measure-Command {
			$response = Invoke-RestMethod -Uri $Uri -Method $Method -Body $PostBody
			}
	}
	else
	{
		$measurement = Measure-Command {
		$response = Invoke-RestMethod -Uri $Uri -Method $Method 
		}
	}

	if($Format -eq "XML")
	{
		$selectedNode = $response.SelectSingleNode($ValuePath)
		$resultBag.AddValue("Value",([double]::Parse($selectedNode.InnerText)))
		$resultBag.AddValue("Success","true")
	}

	if($Format -eq "JSON")
	{
		if($ValuePath.StartsWith("["))
		{
			$invokeResult = Invoke-Expression ('$response' + $ValuePath)
		}
		else
		{
			$invokeResult = Invoke-Expression ('$response.' + $ValuePath)
		}
		$resultBag.AddValue("Value",([double]::Parse($invokeResult)))
		$resultBag.AddValue("Success","true")
	}

	$resultBag.AddValue("MS",$measurement.TotalMilliseconds)
}
catch {
	$api.LogScriptEvent('GetRestReading.ps1', 3450, 1, $_);
	$resultBag.AddValue("Success","false")
	$resultBag.AddValue("Exception",$_)
}

$resultBag

