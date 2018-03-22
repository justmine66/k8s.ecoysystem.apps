# kubectl scale 
>eg: Directly update the replicas field in the live configuration by using kubectl scale.
>usage: kubectl scale deployment/nginx-deployment --replicas=2
# kubectl apply 
>**Apply the changes made to the configuration file**
>usage: kubectl apply -f https://k8s.io/docs/concepts/overview/object-management-kubectl/update_deployment.yaml
# kubectl exec 
>**Execute a command in a container**
>usage: kubectl exec -it lifecycle-demo -- /bin/bash 
# kubectl delete
>Ç¿ÖÆÉ¾³ýpod: kubectl delete <resource> --grace-period=0 --force