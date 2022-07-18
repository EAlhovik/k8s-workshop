
# k8s-workshop

Kubernetes, also known as K8s, is an open-source system for automating deployment, scaling, and management of containerized applications.


## Pre-requisites for workshop
1. Installed [Docker desktop](https://www.docker.com/products/docker-desktop/)
2. Kubernetes in enabled in [Docker desktop](https://docs.docker.com/desktop/kubernetes)
3. Select docker desktop as current context `kubectl config use-context docker-desktop`
4. Clone current repo locally

> to make the learning process a little more fun, here is an app that we will try to build

# Application description

Develop an API server for the globe wide application called CurrentTime.com.

## Solution requirements

- API server should have `GET /api/time` end-point that will return an object that will contain current time.

- The application should be accessible on port `30080`

- We don't know yet in what environment we are deploying the application, so the Portability of the application is very important.

- We can't afford a full-time engineer to look after the application, so the application should be Self-Healing (auto-run after reboot, auto re-run in case of app issues)

- We expect our application to be very successful, so we need a horizontal scaling mechanism

- We plan to release new versions frequently, so we need a deployment mechanism with a as little downtime as possible. 



Basic Kubernetes commands we need to know before we get started
- `docker ps`
- `kubectl apply -f .` Creating objects
- `kubectl delete -f .` Deleting resources



## Resources used to create this document
- [Dockerize an ASP.NET Core application](https://docs.docker.com/samples/dotnetcore/)
- [kubectl Cheat Sheet](https://kubernetes.io/docs/reference/kubectl/cheatsheet/)

```
docker ps
```


ingress 
https://stackoverflow.com/questions/65193758/enable-ingress-controller-on-docker-desktop-with-wls2


milestones
1. run container-based application on port 8001
2. enable containers to restore in case of failure
3. scale out 



https://www.linkedin.com/pulse/deploy-multiple-version-applications-k8s-rajesh-kumar