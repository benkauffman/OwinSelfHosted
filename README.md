# OwinSelfHosted
C# self hosted OWIN web API

There is no need to clone the repo ...
<i>Just</i> install <a href="https://docs.docker.com/engine/installation/">docker</a>

<br>Run:
  <br>`docker build -t owin-web-service https://github.com/benkauffman/OwinSelfHosted.git#master:OwinSelfHosted` to build the image
<br>Then run:
  <br>`docker run -d -h localhost -p 9000:9000 owin-web-service` to run the image in a container

<br>You can then navigate to or curl the API at `http://localhost:9000/api/example`

<br>You can stop and remove the container with
  <br>`docker rm $(docker ps -a -q  --filter ancestor=owin-web-service) -f`
