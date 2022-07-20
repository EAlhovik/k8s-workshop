# Deployment
A Deployment provides declarative updates for Pods.
You describe a desired state in a Deployment, and the Deployment changes the actual state to the desired state.
The process of manually updating containerized applications can be time consuming and tedious. A Kubernetes deployment makes this process automated and repeatable.

1. Review Deployment manifest. Compare it with Pod manifest

2. Create a Deployment

`kubectl apply -f .\deployment.yaml`

3. Stop all running containers. See that the container will start automatically

`docker stop $(docker ps -q)`

4. Change desired state in a Deployment to `8` replicas of the application and apply the change with a command from `step 2`. Check that the number of pods has changed.

```diff
spec:
-  replicas: 1
+  replicas: 8
  selector:
```

5. Change the image tag to `2.0` and apply the change with a command from `step 2`.

```diff
      - name: time-server-api-container
-        image: time-server-api:1.0
+        image: time-server-api:2.0
        imagePullPolicy: Never
```

## Results
- [x] Application is working. *Application accessible only inside k8s network
- [x] Portable. We can run application on any host that has Docker Engine
- [x] Has self healing
- [x] Scalable
- [x] Rolling deployment
