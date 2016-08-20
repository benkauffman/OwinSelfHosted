# OwinSelfHosted
C# self hosted OWIN web API

There is no need to clone the repo ...
<br>install <a href="https://docs.docker.com/engine/installation/">docker</a>
<br>run `docker build -t owin-web-service https://github.com/benkauffman/OwinSelfHosted.git#master:OwinSelfHosted` to build the image
<br>then run `docker run -d -h localhost -p 9000:9000 owin-web-service` to run the image in a container
<br>you can then navigate to or curl `http://localhost:9000/api/example`
