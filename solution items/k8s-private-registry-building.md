# ²Î¿¼
>https://kubernetes.io/docs/tasks/configure-pod-container/pull-image-private-registry/

# Create a Secret in the cluster that holds your authorization token
kubectl delete secret registry-key
kubectl create secret docker-registry registry-key \
--docker-server=<your-registry-server> \
--docker-username=<your-name> \
--docker-password=<your-pword> \
--docker-email=<your-email>

# Inspecting the Secret registry-key
kubectl get secret registry-key --output=yaml
kubectl get secret registry-key --output="jsonpath={.data.\.dockerconfigjson}" | base64 -d

