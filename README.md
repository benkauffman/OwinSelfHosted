# OwinSelfHosted
C# self hosted OWIN web API

There is no need to clone the repo ...
<br><i>Just</i> install <a href="https://docs.docker.com/engine/installation/">docker</a>
<br>Run `docker build -t owin-web-service https://github.com/benkauffman/OwinSelfHosted.git#master:OwinSelfHosted` to build the image
<br>Then run `docker run -d -h localhost -p 9000:9000 owin-web-service` to run the image in a container
<br>You can then navigate to or curl the API at `http://localhost:9000/api/example`

<p>
You can stop and remove the container with `docker rm $(docker ps -a -q  --filter ancestor=owin-web-service) -f`
</p>