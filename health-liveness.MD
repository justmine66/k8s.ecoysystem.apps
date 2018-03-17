cat << eof>health-liveness.yml

kubectl create -f health-liveness.yml
kubectl apply -f health-liveness.yml
kubectl delete -f health-liveness.yml
kubectl get pod
kubectl delete pod health-liveness-api
kubectl describe pod health-liveness-api

