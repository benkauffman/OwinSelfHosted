# OwinSelfHosted
C# self hosted OWIN web API

No need to clone the repo... if you have docker installed
<br> to build the image run `docker build -t owin-web-service https://github.com/benkauffman/OwinSelfHosted.git#master:OwinSelfHosted`
<br> to run the image in a container run `docker run -d -h localhost -p 9000:9000 owin-web-service`
