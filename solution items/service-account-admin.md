#Create Service Account and ClusterRoleBinding
kubectl create -f service-account-admin.yaml
# Bearer Token
kubectl -n kube-system describe secret $(kubectl -n kube-system get secret | grep admin-user | awk '{print $1}')
