cat << eof>empDir.yml
kubectl apply -f empDir.yml
kubectl logs producer-consumer consumer

# mysql
cat << eof>mysql-pv.yml
cat << eof>mysql-pvc.yml
cat << eof>mysql.yml

kubectl apply -f mysql.yml
kubectl delete -f mysql.yml
kubectl apply -f mysql-pv.yml
kubectl delete -f mysql-pv.yml
kubectl apply -f mysql-pvc.yml

kubectl get pv,pvc