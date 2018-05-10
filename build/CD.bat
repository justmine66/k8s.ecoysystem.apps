set build-base-path=../src
set outpust-base-path=../../build
set registry-host=registry.wuling.com
set username=justmine

set first=HelloWorld.Api
set version=0.0.1
set imagename=helloworld.api
set imagefullname=%registry-host%/%username%/%imagename%:%version%
dotnet publish %build-base-path%/%first%/%first%.csproj -o %outpust-base-path%/%first% -c release
docker build -t %imagefullname% ./%first%
docker push %imagefullname%
rd /s /q %first% 

pause
goto EOF


