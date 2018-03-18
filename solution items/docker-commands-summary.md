--保证容器长期运行，容器的生命周期依赖于启动时执行的命令，只要该命令不结束，容器也就不会退出
docker run --name healthchecksapi -d -p 8000:8000 justmine/healthchecksapi:v1.0 /bin/bash -c "while true; do sleep 1; done"
--容器间数据共享
docker run --name web1 -d -p 80 -v ~/htdocs:/usr/local/apache2/htdocs httpd
docker run --name web2 -d -p 80 -v ~/htdocs:/usr/local/apache2/htdocs httpd
docker run --name web3 -d -p 80 -v ~/htdocs:/usr/local/apache2/htdocs httpd
# volume container 共享数据 只是提供数据，本身不需要处于运行状态
>docker create --name vc_data \
>-v ~/htdocs:/usr/local/apache2/htdocs \
>-v /other/useful/tools \
busybox
## 其他容器可以通过 --volumes-from 使用 vc_data 这个 volume container
>docker run --name web4 -d -p 80 -volumes-from vc_data httpd
