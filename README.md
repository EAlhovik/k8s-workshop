
# k8s-workshop

Kubernetes, also known as K8s, is an open-source system for automating deployment, scaling, and management of containerized applications.

## Pre-requisites for workshop
1. Installed [Docker desktop](https://www.docker.com/products/docker-desktop/)
2. Kubernetes in enabled in [Docker desktop](https://docs.docker.com/desktop/kubernetes)
3. Select docker desktop as current context `kubectl config use-context docker-desktop`

> _
> #### Plan for today
>
> - Build a simple application
> - Manually deploy the application
> - Automate the deployment
> 
> Please ask questions
>
> #### Tools we will use
> - Terminal
> - Docker Desktop
> - Lens


# Application description

Develop an API server for the globe wide application called CurrentTime.com.

## Solution requirements

- API server should have `GET /api/time` end-point that will return an object that will contain current time

- The application should be accessible on port `30080`

- We don't know yet in what environment we are deploying the application, so the **Portability** of the application is very important

- We can't afford a full-time engineer to look after the application, so the application should be **Self-Healing** (auto-run after reboot, auto re-run in case of app issues)

- We expect our application to be very successful, so we need a horizontal **scaling mechanism**

- We plan to release new versions frequently, so we need a **deployment mechanism** with a as little downtime as possible



Basic Kubernetes commands we need to know before we get started
- `docker ps` - get list of running container
- `kubectl apply -f .` - apply k8s manifests from current folder
- `kubectl delete -f .` delete k8s manifests from current folder


## Resources used to create this document
- [Original k8workshop](https://github.com/u-abramchuk/k8workshop)
- [Dockerize an ASP.NET Core application](https://docs.docker.com/samples/dotnetcore/)
- [kubectl Cheat Sheet](https://kubernetes.io/docs/reference/kubectl/cheatsheet/)

