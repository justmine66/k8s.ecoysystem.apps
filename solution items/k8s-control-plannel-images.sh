images=(
kube-apiserver-amd64:v1.9.4
kube-controller-manager-amd64:v1.9.4
kube-scheduler-amd64:v1.9.4
kube-proxy-amd64:v1.9.4
etcd-amd64:3.1.11
pause-amd64:3.0
k8s-dns-sidecar-amd64:1.14.7
k8s-dns-kube-dns-amd64:1.14.7
k8s-dns-dnsmasq-nanny-amd64:1.14.7 
)

for imageName in ${images[@]};
do
    sudo docker pull justmine/$imageName;
	sudo docker tag justmine/$imageName gcr.io/google_containers/$imageName;
	sudo docker rmi justmine/$imageName;
done