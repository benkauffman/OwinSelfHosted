REM stop all running containers
docker stop $(docker ps -a -q)
docker rm $(docker ps -a -q) -f

REM run the webservice inside a container
REM docker run -p 8080:9000 owin-web-service

REM attach to the container's bash shell
REM docker run -it -p 8080:9000 owin-web-service /bin/bash

docker run -d -h localhost -p 9000:9000 owin-web-service
