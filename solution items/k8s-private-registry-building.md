# ²Î¿¼
>https://kubernetes.io/docs/tasks/configure-pod-container/pull-image-private-registry/

# Create a Secret in the cluster that holds your authorization token
kubectl delete secret regcred
kubectl create secret docker-registry regcred \
--docker-server=<your-registry-server> \
--docker-username=<your-name> \
--docker-password=<your-pword> \
--docker-email=<your-email>

kubectl create secret docker-registry regcred \
--docker-server=registry.geekbuy.cn \
--docker-username=justmine \
--docker-password=dkjustmine.c0m \
--docker-email=3538307147@qq.com

# Inspecting the Secret regcred
kubectl get secret regcred --output=yaml
kubectl get secret regcred --output="jsonpath={.data.\.dockerconfigjson}" | base64 -d

