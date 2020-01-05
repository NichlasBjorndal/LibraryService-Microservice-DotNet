$counter = 0

Do {

kubectl top node | Out-File -Append -FilePath .\kubectl-resources.txt

start-sleep -seconds 5
$counter = $counter + 5

}

while ($counter -lt 35)