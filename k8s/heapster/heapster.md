cat << eof>influxdb.yaml
cat << eof>grafana.yaml
cat << eof>heapster.yaml

kubectl apply -f influxdb.yaml
kubectl apply -f grafana.yaml
kubectl apply -f heapster.yaml

kubectl delete -f influxdb.yaml
kubectl delete -f grafana.yaml
kubectl delete -f heapster.yaml

docker pull justmine/heapster-amd64:v1.4.2 
docker tag justmine/heapster-amd64:v1.4.2  k8s.gcr.io/heapster-amd64:v1.4.2
docker rmi justmine/heapster-amd64:v1.4.2

docker pull justmine/heapster-influxdb-amd64:v1.3.3 
docker tag justmine/heapster-influxdb-amd64:v1.3.3  k8s.gcr.io/heapster-influxdb-amd64:v1.3.3
docker rmi justmine/heapster-influxdb-amd64:v1.3.3

docker pull justmine/heapster-grafana-amd64:v4.4.3 
docker tag justmine/heapster-grafana-amd64:v4.4.3  k8s.gcr.io/heapster-grafana-amd64:v4.4.3
docker rmi justmine/heapster-grafana-amd64:v4.4.3 

kubectl get pods -n kube-system

kubectl get services --namespace=kube-system monitoring-grafana monitoring-influxdb
kubectl -n kube-system edit service monitoring-grafana
kubectl -n kube-system edit service monitoring-influxdb

# kube-system
http://registry.geekbuy.cn:30017
http://registry.geekbuy.cn:31261

# k8s-ecoysystem-apps
grafana: http://registry.geekbuy.cn:32537
influxdb: http://registry.geekbuy.cn:31271
