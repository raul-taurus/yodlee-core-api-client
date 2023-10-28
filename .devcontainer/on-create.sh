#!/usr/bin/env bash

set -e

# nuget config
dotnet nuget add source --username ${GH_USER} --password ${GH_PAT} --store-password-in-clear-text --name githubwealthcom "https://nuget.pkg.github.com/wealthcom/index.json"

# .NET tools
dotnet tool install -g Amazon.Lambda.Tools
dotnet new install Amazon.Lambda.Templates
export PATH="$PATH:/home/vscode/.dotnet/tools"

# Node.js
npm install -g npm 
npm install -g cdk 
npm install -g graphql-schema-utilities

# awscli
curl "https://awscli.amazonaws.com/awscli-exe-linux-x86_64.zip" -o "/tmp/awscliv2.zip"
cd /tmp/
unzip -q awscliv2.zip
sudo sh ./aws/install

# Update APT
sudo apt-get update
sudo apt-get upgrade -y
sudo apt-get install vim -y

# Docker buildx
sudo docker run --rm --privileged multiarch/qemu-user-static --reset -p yes
