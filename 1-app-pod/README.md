# Pods
Pods are the smallest deployable units of computing that you can create and manage in Kubernetes.
We need to treat pod as immutable object. If we need to make a change to pod, we need to remove old pod and create a new one.

1. Review Pod manifest. Make sure that you use application version 1.0

2. Create a pod

`kubectl apply -f .\pod.yaml`

3. Stop all running containers. See that the container will start automatically

`docker stop $(docker ps -q)`

4. Remove the Pod and go to the next section

`kubectl delete -f .\pod.yaml`


## Results
- [x] Application is working
- [x] Portable. We can run application on any host that has Docker Engine
- [x] Has self-healing
- [ ] Not scalable
- [ ] Manual deployment only