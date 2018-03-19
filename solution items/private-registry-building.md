# 参考 
>https://docs.docker.com/registry/deploying/
>https://docs.docker.com/registry/insecure/#deploy-a-plain-http-registry
>repository 的完整格式为：[registry-host]:[port]/[username]/xxx
# 配置[registry-host]
>在每一台需要使用私有仓库的机器上将 registry.geekbuy.cn 写入到/etc/hosts
# 配置运行http
## 1、http方式,修改配置文件
repeat this steps on every engine host that wants to access your registry.
Edit the daemon.json file, whose default location is /etc/docker/daemon.json on Linux or C:\ProgramData\docker\config\daemon.json on Windows Server. 
If the daemon.json file does not exist, create it. Assuming there are no other settings in the file, it should have the following contents:
{
  "insecure-registries" : ["registry.geekbuy.cn:5000"]
}
## 2、重启docker服务
>systemctl daemon-reload
>systemctl restart docker
# 运行容器
> http: docker run --restart=always --name registry.geekbuy.cn -d -p 5000:5000 -v /geekbuy/registry registry:2
> https: docker run -d \
  --restart=always \
  --name registry \
  -v `pwd`/certs:/certs \
  -e REGISTRY_HTTP_ADDR=0.0.0.0:443 \
  -e REGISTRY_HTTP_TLS_CERTIFICATE=/certs/domain.crt \
  -e REGISTRY_HTTP_TLS_KEY=/certs/domain.key \
  -p 443:443 \
  registry:2
# 重命名image
>docker tag [image-name] registry.geekbuy.cn/[username]/[image-name]
# 推送到私有仓库
>docker push registry.geekbuy.cn/[username]/[image-name]
# 从私有仓库拉取
>docker pull registry.geekbuy.cn/[username]/[image-name]
# 查看私用仓库中的镜像
>curl -XGET registry.geekbuy.cn:5000/v2/_catalog
>或
>在浏览器上访问 http://registry.geekbuy.cn:5000/v2/_catalog
# stop and remove local registry  
>docker container stop registry.geekbuy.cn && docker container rm -v registry.geekbuy.cn
>或
>docker stop registry.geekbuy.cn && docker rm -v registry.geekbuy.cn



