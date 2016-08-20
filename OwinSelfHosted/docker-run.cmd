REM stop all running containers
docker stop $(docker ps -a -q)

REM run the webservice inside a container
docker run -p 8080:9000 owin-web-service

REM attach to the container's bash shell
docker run -it -p 8080:9000 owin-web-service /bin/bash
