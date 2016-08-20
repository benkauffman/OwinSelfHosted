# We use the microsoft/aspnet image as a starting point.
FROM microsoft/aspnet

# Run updates and install git
RUN apt-get update
RUN apt-get install git -y

# Create a folder to clone our source code
RUN mkdir repositories

# Set our working folder
WORKDIR repositories

# Clone the source code
RUN git clone https://github.com/benkauffman/OwinSelfHosted.git

# Set our working folder
WORKDIR OwinSelfHosted

# Restore nuget packages
RUN nuget restore OwinSelfHosted.sln

# Build the application
RUN xbuild OwinSelfHosted.sln /p:DefineConstants=LINUX

# Expose port 9000 for the application.
EXPOSE 9000

# Start de application using mono!!!
ENTRYPOINT ["mono", "OwinSelfHosted/bin/Debug/OwinSelfHosted.exe"]




# FROM mono:4.4.2.11

# EXPOSE 9000

# CMD ["mono", "./OwinSelfHosted/OwinSelfHosted.exe"]
# CMD ["pwd"]
# CMD ["ls"]
