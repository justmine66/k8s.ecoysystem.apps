# ²Î¿¼ https://kubernetes.io/docs/tasks/configure-pod-container/configure-pod-configmap/
# create configmaps
>where <map-name> is the name you want to assign to the ConfigMap and <data-source> is the directory, file, or literal value to draw the data from.
>The data source corresponds to a key-value pair in the ConfigMap, where
>	key = the file name or the key you provided on the command line, and
>	value = the file contents or the literal value you provided on the command line.
>**kubectl create configmap <map-name> <data-source>**
>usage:
>	1. Create ConfigMaps from directories
>	   kubectl create configmap game-config --from-file=configmap
>   2. Define the key to use when creating a ConfigMap from a file
>	   kubectl create configmap game-config-3 --from-file=<my-key-name>=<path-to-file>
>   
# view configmaps
kubectl describe configmaps game-config
kubectl get configmaps game-config -o yaml