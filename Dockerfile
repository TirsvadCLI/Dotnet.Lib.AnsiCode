################################################################################
# Build stage
################################################################################
FROM tirsvad/tirsvadcli_debian13_nginx AS build
WORKDIR /src

COPY ./ /src/
RUN ["apt-get", "install", "-y", "dotnet-sdk-10.0"]
RUN ["dotnet", "restore"]
RUN ["dotnet", "build", "--no-restore", "-c", "Release"]

################################################################################
# Test stage
################################################################################
FROM build AS test
SHELL ["/bin/bash"]
WORKDIR /src

COPY tools/docker/run_tests.sh /run_tests.sh
RUN ["chmod", "+x", "/run_tests.sh"]

ENTRYPOINT ["/run_tests.sh"]
