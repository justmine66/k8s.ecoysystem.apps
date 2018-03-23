# registry
docker tag helloworldapi:v2.2 justmine/helloworldapi:v2.2
docker push justmine/helloworldapi:v2.2

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

# configmap
cat << eof>hello-world-configmap.yml
kubectl apply -f hello-world-configmap.yml  
kubectl delete -f hello-world-configmap.yml  
kubectl get configmaps externalcfg -o yaml
kubectl describe configmaps externalcfg -n k8s-ecoysystem-apps  

# deployment
cat << eof>hello-world-deployment.yml
cat << eof>hello-world-deployment-with-settings.yml

kubectl apply -f hello-world-deployment.yml --record
kubectl apply -f hello-world-deployment-with-settings.yml --record
kubectl create -f hello-world-deployment.yml
kubectl delete -f hello-world-deployment.yml
kubectl delete -f hello-world-deployment.yml --cascade=false 
kubectl describe deployment hello-world-api-deployment

# service
rm hello-world-service.yml && cat << eof>hello-world-service.yml

kubectl apply -f hello-world-service.yml
kubectl get service hello-world-api-svc






