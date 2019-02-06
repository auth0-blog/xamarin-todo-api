
DB_NAME=todo_db
DB_PASSWORD=password
CONTAINER_NAME=todo_db

if [ ! "$(docker ps -aqf name=$CONTAINER_NAME)" ]; then
  docker run -it \
  -e POSTGRES_USER=$DB_NAME \
  -e POSTGRES_PASSWORD=$DB_PASSWORD \
  -p 5432:5432 \
  --name $CONTAINER_NAME \
  postgres
elif [ "$(docker ps -aqf status=exited -f name=$CONTAINER_NAME)" ]; then
  docker start -i $CONTAINER_NAME
else
  echo "$CONTAINER_NAME is already running"
fi
