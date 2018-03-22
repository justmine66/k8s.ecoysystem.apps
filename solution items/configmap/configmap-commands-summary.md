# ´´½¨ConfigMap 
kubectl create configmap myconfigmap --from-literal=config1=xxx --from-literal=config2=yyy
kubectl create configmap myconfigmap --from-file=./config1 --from-file=./config2
kubectl create configmap myconfigmap --from-env-file=env.txt
kubectl apply -f configmap-spec-annotations.yml

cat << eof>configmap-spec-annotations.yml