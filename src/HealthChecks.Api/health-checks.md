# 推送镜像到私有仓库(registry.geekbuy.cn)
docker tag healthchecksapi:dev registry.geekbuy.cn/justmine/healthchecksapi:v1.1
docker tag healthchecksapi:dev justmine/healthchecksapi:v1.1
http: docker push registry.geekbuy.cn:5000/justmine/healthchecksapi:v1.1
https: docker push registry.geekbuy.cn/justmine/healthchecksapi:v1.1

# 从私有仓库(registry.geekbuy.cn)拉取镜像到master
http: docker pull registry.geekbuy.cn:5000/justmine/healthchecksapi:v1.1 
https: docker push registry.geekbuy.cn/justmine/healthchecksapi:v1.1
docker tag registry.geekbuy.cn:5000/justmine/healthchecksapi:v1.1 justmine/healthchecksapi:v1.1

# 在master上创建yml文件
rm health-checks-pod.yml && cat << eof>health-checks-pod.yml

# 在master上创建pod
kubectl create -f health-checks-pod.yml
kubectl apply -f health-checks-pod.yml
kubectl delete -f health-checks-pod.yml

# 查看pod状态
kubectl get pod
kubectl describe pod health-checks-api
kubectl delete pod health-checks-api

