#!/bin/bash
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
kubernetes-dashboard-amd64:v1.8.3
)

for imageName in ${images[@]};
do
    docker pull justmine/$imageName;
	docker tag justmine/$imageName gcr.io/google_containers/$imageName;
	docker tag justmine/$imageName k8s.gcr.io/$imageName;
	docker rmi justmine/$imageName;
done
docker pull quay.io/coreos/flannel:v0.9.1-amd64;