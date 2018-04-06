# ²Î¿¼
>https://kubernetes.io/docs/tasks/configure-pod-container/pull-image-private-registry/

# Create a Secret in the cluster that holds your authorization token
kubectl delete secret registry-key
kubectl create secret docker-registry registry-key \
--docker-server=<your-registry-server> \
--docker-username=<your-name> \
--docker-password=<your-pword> \
--docker-email=<your-email>

kubectl delete secret registry-key
kubectl -n k8s-ecoysystem-apps create secret docker-registry registry-key \
--docker-server=registry.wuling.com \
--docker-username=justmine \
--docker-password=<your-pword> \
--docker-email=3538307147@qq.com

# Inspecting the Secret registry-key
kubectl get secret registry-key --output=yaml
kubectl get secret registry-key --output="jsonpath={.data.\.dockerconfigjson}" | base64 -d

docker run -d \
  --restart=always \
  --name registry.wuling.com \
  -v `pwd`/certs:/certs \
  -e REGISTRY_HTTP_ADDR=0.0.0.0:443 \
  -e REGISTRY_HTTP_TLS_CERTIFICATE=/certs/domain.crt \
  -e REGISTRY_HTTP_TLS_KEY=/certs/domain.key \
  -p 443:443 \
  registry:2

--test
docker pull justmine/helloworldapi:v2.2 
docker tag justmine/helloworldapi:v2.2 registry.wuling.com/justmine/helloworldapi:v2.2
docker push registry.wuling.com/justmine/helloworldapi:v2.2

docker pull justmine/healthchecksapi:v1.5 
docker tag justmine/healthchecksapi:v1.5 registry.wuling.com/justmine/healthchecksapi:v1.5 
docker push registry.wuling.com/justmine/healthchecksapi:v1.5 

