# FitKitAPI

## Activities

### GET
```
https://localhost:7051/api/Activities
```
> ### Response
 ```
  {
    "userId": 0,
    "stepsTaken": 0,
    "caloriesBurned": 0,
    "distanceCovered": 0,
    "activeMinutes": 0,
    "createdDate": "2024-04-02T12:00:04.103Z",
    "createdBy": 0,
    "modifiedDate": "2024-04-02T12:00:04.103Z",
    "modifiedBy": 0
  }
]
```

### POST
```
https://localhost:7051/api/Activities
```
> ### Request body
```
{
  "userId": 0,
  "stepsTaken": 0,
  "caloriesBurned": 0,
  "distanceCovered": 0,
  "activeMinutes": 0,
  "createdDate": "2024-04-02T12:11:56.306Z",
  "createdBy": 0,
  "modifiedDate": "2024-04-02T12:11:56.306Z",
  "modifiedBy": 0
}
```
> ### Response body
```
{
  "userId": 1,
  "stepsTaken": 0,
  "caloriesBurned": 0,
  "distanceCovered": 0,
  "activeMinutes": 0,
  "createdDate": "2024-04-02T12:11:56.306Z",
  "createdBy": 0,
  "modifiedDate": "2024-04-02T12:11:56.306Z",
  "modifiedBy": 0
}
```

### GET{id}

```
https://localhost:7051/api/Activities/{id}
```

| Params     | Type |  Description  |
|----------- | ------- | ------------- |
| `id`  |  `int32` | *Required*. UserId to be fetched |  
> ### Response body
```
{
  "userId": 0,
  "stepsTaken": 0,
  "caloriesBurned": 0,
  "distanceCovered": 0,
  "activeMinutes": 0,
  "createdDate": "2024-04-02T12:16:51.362Z",
  "createdBy": 0,
  "modifiedDate": "2024-04-02T12:16:51.362Z",
  "modifiedBy": 0
}
```

### POST

```
https://localhost:7051/api/Activities/{id}
```

| Params     | Type |  Description  |
|----------- | ------- | ------------- |
| `id`  |  `int32` | *Required*. UserId to be fetched |
> ### Request body
```
{
  "userId": 0,
  "stepsTaken": 0,
  "caloriesBurned": 0,
  "distanceCovered": 0,
  "activeMinutes": 0,
  "createdDate": "2024-04-02T12:16:51.362Z",
  "createdBy": 0,
  "modifiedDate": "2024-04-02T12:16:51.362Z",
  "modifiedBy": 0
}
```
> ### Response body
```
{
  "userId": 0,
  "stepsTaken": 0,
  "caloriesBurned": 0,
  "distanceCovered": 0,
  "activeMinutes": 0,
  "createdDate": "2024-04-02T12:16:51.362Z",
  "createdBy": 0,
  "modifiedDate": "2024-04-02T12:16:51.362Z",
  "modifiedBy": 0
}
```

### DELETE

```
https://localhost:7051/api/Activities/{id}
```

| Params     | Type |  Description  |
|----------- | ------- | ------------- |
| `id`  |  `int32` | *Required*. UserId to be deleted |  
> Responses

| Code | Description |
| ---- | ----------- |
| `200` | Success    |

## Goals

### GET
```
https://localhost:7051/api/Goals
```

> ### Response body schema
```
{
  "userId": 0,
  "weightLoss": 0,
  "muscleGain": 0,
  "enduranceMovement": 0,
  "createdDate": "2024-04-02T12:55:01.889Z",
  "createdBy": 0,
  "modifiedDate": "2024-04-02T12:55:01.889Z",
  "modifiedBy": 0
}
```

### POST
```
https://localhost:7051/api/Goals
```
> ### Request body schema
```
{
  "userId": 0,
  "weightLoss": 0,
  "muscleGain": 0,
  "enduranceMovement": 0,
  "createdDate": "2024-04-02T12:55:01.889Z",
  "createdBy": 0,
  "modifiedDate": "2024-04-02T12:55:01.889Z",
  "modifiedBy": 0
}
```

### GET{id}
```
https://localhost:7051/api/Goals
```

| Params     | Type |  Description  |
|----------- | ------- | ------------- |
| `id`  |  `int32` | *Required*. UserId to be fetched |  

> ### Response body schema
```
{
  "userId": 0,
  "weightLoss": 0,
  "muscleGain": 0,
  "enduranceMovement": 0,
  "createdDate": "2024-04-02T12:55:01.889Z",
  "createdBy": 0,
  "modifiedDate": "2024-04-02T12:55:01.889Z",
  "modifiedBy": 0
}
```

### PUT
```
https://localhost:7051/api/Goals
```

| Params     | Type |  Description  |
|----------- | ------- | ------------- |
| `id`  |  `int32` | *Required*. UserId to be updated |  

> ### Request body schema
```
{
  "userId": 0,
  "weightLoss": 0,
  "muscleGain": 0,
  "enduranceMovement": 0,
  "createdDate": "2024-04-02T12:55:01.889Z",
  "createdBy": 0,
  "modifiedDate": "2024-04-02T12:55:01.889Z",
  "modifiedBy": 0
}
```

> ### Response body schema
```
{
  "userId": 0,
  "weightLoss": 0,
  "muscleGain": 0,
  "enduranceMovement": 0,
  "createdDate": "2024-04-02T12:55:01.889Z",
  "createdBy": 0,
  "modifiedDate": "2024-04-02T12:55:01.889Z",
  "modifiedBy": 0
}
```

### DELETE
```
https://localhost:7051/api/Goals
```

| Params     | Type |  Description  |
|----------- | ------- | ------------- |
| `id`  |  `int32` | *Required*. UserId to be deleted| 

> ### Responses

| Code | Description |
| ---- | ----------- |
| `200` | Success    |



