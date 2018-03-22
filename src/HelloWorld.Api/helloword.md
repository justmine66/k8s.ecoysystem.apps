# registry
docker tag helloworldapi:v1.0 justmine/helloworldapi:v1.0
docker push justmine/helloworldapi:v1.0

# docker
docker run -d -p 8001:80 --name helloworldapi justmine/helloworldapi:v1.0

# pod
rm hello-world-pod.yml && cat << eof>hello-world-pod.yml

kubectl apply -f hello-world-pod.yml
kubectl create -f hello-world-pod.yml
kubectl delete -f hello-world-pod.yml

kubectl get pod -n k8s-ecoysystem-apps -o wide
kubectl describe pod helloworldapi -n k8s-ecoysystem-apps  
kubectl delete pod helloworldapi -n k8s-ecoysystem-apps

# deployment
rm hello-world-deployment.yml && cat << eof>hello-world-deployment.yml

kubectl apply -f hello-world-deployment.yml
kubectl create -f hello-world-deployment.yml
kubectl delete -f hello-world-deployment.yml
kubectl delete -f hello-world-deployment.yml --cascade=false 
kubectl describe deployment hello-world-api-deployment

# service
rm hello-world-service.yml && cat << eof>hello-world-service.yml

kubectl apply -f hello-world-service.yml
kubectl get service hello-world-api-svc






