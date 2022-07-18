# Service
An abstract way to expose an application running on a set of Pods as a network service.
With Kubernetes you don't need to modify your application to use an unfamiliar service discovery mechanism. Kubernetes gives Pods their own IP addresses, and can **load-balance** across them.

1. Review Service manifest. Make sure we use desired port open

2. Create a Service. Note The command below will create the Service and update existing deployment matching it by name

`kubectl apply -f .`

3. Access application. http://localhost:30080

4. To remove deployment and service, we can use following command

`kubectl delete -f .`


## Results
- [x] Application is working
- [x] Portable. We can run application on any host that has Docker Engine
- [x] Has self healing
- [x] Scalable
- [x] Rolling deployment