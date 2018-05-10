# ²Î¿¼Á´½Ó
https://hub.docker.com/_/redis/
https://github.com/docker-library/redis
https://github.com/kubernetes/examples/tree/master/staging/storage/redis

# Senior
a master with replicated slaves, as well as replicated redis sentinels which are used for health checking and failover.

# Setting
kubectl -n geekbuying-light-addons apply -f /root/geekbuying/kubernetes/product-cluster/redis/redis-master.yml
kubectl -n geekbuying-light-addons apply -f /root/geekbuying/kubernetes/product-cluster/redis/redis-sentinel.yml
kubectl -n geekbuying-light-addons apply -f /root/geekbuying/kubernetes/product-cluster/redis/redis-sentinel-service.yml

# visitor
## inner 
10.100.60.123:6379

registry.xcmaster.com/geekbuying/redis

