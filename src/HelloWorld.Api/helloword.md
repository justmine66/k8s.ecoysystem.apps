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

kubectl exec -n k8s-ecoysystem-apps -it helloworldapi-768889b99b-chxmh sh 

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
# monitor the progress for a Deployment
kubectl rollout status deployments hello-world-api-deployment

kubectl rollout history hello-world-api-deployment
kubectl rollout history hello-world-api-deployment --revision=2
# Rolling Back to a Previous Revision
kubectl rollout undo hello-world-api-deployment
# rollback to a specific revision
kubectl rollout undo deployment/nginx-deployment --to-revision=2
# Scaling a Deployment
kubectl scale deployment nginx-deployment --replicas=10
# autoscaling based on the CPU utilization of your existing Pods.
kubectl autoscale deployment nginx-deployment --min=10 --max=15 --cpu-percent=80

# service
cat << eof>hello-world-service.yml

kubectl apply -f hello-world-service.yml
kubectl get service hello-world-api-svc

# configmap
cat << eof>appsetting.yml

kubectl apply -f appsetting.yml








