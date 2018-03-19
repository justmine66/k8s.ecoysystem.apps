
docker tag hellowordapi:dev justmine/hellowordapi:v1.1
docker push justmine/hellowordapi:v1.1

# 在master上创建yml文件
rm hello-world-pod.yml && cat << eof>hello-world-pod.yml

# 在master上创建pod
kubectl create -f hello-world-pod.yml
kubectl apply -f hello-world-pod.yml
kubectl delete -f hello-world-pod.yml

# 查看pod状态
kubectl get pod
kubectl describe pod hello-world-api
kubectl delete pod hello-world-api

#部署服务
rm hello-world-pod.yml && cat << eof>hello-world-service.yml
kubectl apply -f hello-world-service.yml
kubectl get service hello-world-api-svc



