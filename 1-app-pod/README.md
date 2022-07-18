# Pods
Pods are the smallest deployable units of computing that you can create and manage in Kubernetes.

1. Review Pod manifest. Make sure that you use application version 1.0

2. Create a pod

`kubectl apply -f .`

3. Stop all running containers. See that the container will start automatically

`docker stop $(docker ps -q)`

4. Remove the Pod and go to the next section

`kubectl delete -f .`


## Results
- [x] Application is working. *Application accessible only inside k8s network
- [x] Portable. We can run application on any host that has Docker Engine
- [x] Has self healing
- [ ] Not scalable
- [ ] Manual deployment only