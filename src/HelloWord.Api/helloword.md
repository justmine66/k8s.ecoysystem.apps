
docker tag hellowordapi:latest justmine/hellowordapi:v1.3
docker push justmine/hellowordapi:v1.3

# 在master上创建yml文件
rm hello-world-pod.yml && cat << eof>hello-world-pod.yml

# 在master上创建pod
kubectl create -f hello-world-pod.yml
kubectl apply -f hello-world-pod.yml
kubectl delete -f hello-world-pod.yml

# pod
kubectl get pod -n k8s-ecoysystem-apps -o wide
kubectl describe pod helloword-api -n k8s-ecoysystem-apps  
kubectl delete pod helloword-api -n k8s-ecoysystem-apps

# deployment
rm hello-world-deployment.yml && cat << eof>hello-world-deployment.yml
kubectl create -f hello-world-deployment.yml
kubectl apply -f hello-world-deployment.yml
kubectl delete -f hello-world-deployment.yml
kubectl describe deployment hello-world-api-deployment

# service
rm hello-world-service.yml && cat << eof>hello-world-service.yml
kubectl apply -f hello-world-service.yml
kubectl get service hello-world-api-svc






