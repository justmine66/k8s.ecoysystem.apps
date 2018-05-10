# 查看已安装的chart
helm search <chartname>

# 仓库
helm repo list
helm repo add

# Tiller 服务器添加命名权限
kubectl create serviceaccount --namespace kube-system tiller
kubectl create clusterrolebinding tiller-cluster-rule --clusterrole=cluster-admin --serviceaccount=kube-system:tiller
kubectl patch deploy --namespace kube-system tiller-deploy -p '{"spec":{"template":{"spec":{"serviceAccount":"tiller"}}}}'

# 查看已发布的列表
helm ls

# 发布版本
helm install <chart path>