docker build -t justmine/nginx-hosted-exceptionless-ui:1.0 .
docker push justmine/nginx-hosted-exceptionless-ui:1.0

kubectl -n k8s-ecoysystem-apps get po
kubectl -n k8s-ecoysystem-apps exec -it nginx-hosted-exceptionless-ui-5f4ff6b649-kps9w /bin/bash

kubectl -n k8s-ecoysystem-apps exec -it nginx-deployment-6c45fc49cb-zdlfb /bin/bash