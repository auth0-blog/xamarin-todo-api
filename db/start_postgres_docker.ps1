$DB_NAME="todo_db"
$DB_PASSWORD="password"
$CONTAINER_NAME="todo_db"

if (!(iex "docker ps -aqf name=$CONTAINER_NAME")) {
	iex "docker run -it -e POSTGRES_USER=$DB_NAME -e POSTGRES_PASSWORD=$DB_PASSWORD -p 5432:5432 --name $CONTAINER_NAME postgres"
} elseif (iex "docker ps -aqf status=exited -f name=$CONTAINER_NAME") {
	iex "docker start -i $CONTAINER_NAME"
} else {
	Write-Host "Database is already started"
}
