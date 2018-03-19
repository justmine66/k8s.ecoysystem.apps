# 生成自签名证书
$ mkdir -p certs

$ openssl req \
  -newkey rsa:4096 -nodes -sha256 -keyout certs/domain.key \
  -x509 -days 365 -out certs/domain.crt

Be sure to use the name [目标域名] as a CN.

# docker client安装CA证书
sudo mkdir -p /etc/docker/certs.d/registry.geekbuy.cn
sudo cp certs/domain.crt /etc/docker/certs.d/registry.geekbuy.cn/ca.crt
# 安装证书后，重启Docker Daemon
sudo service docker restart
