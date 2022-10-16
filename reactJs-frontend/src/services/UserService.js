import axios from 'axios';

const USER_URL="https://localhost:7269/api/User/getUsers"
const USER_URL_2="https://localhost:7269/api/User/createUser"
const USER_URL_3="https://localhost:7269/api/User/updateUser"
const USER_URL_4="https://localhost:7269/api/User/deleteUser"
const USER_URL_5="https://localhost:7269/api/User/getUser"


class UserService{
    getUsers(){
        return axios.get(USER_URL);
    }
    createUser(user){
        return axios.post(USER_URL_2,user);
    }
    getUserById(userId){
        return axios.get(USER_URL_5 + '/' + userId);
    }
    updateUser(user){
        return axios.put(USER_URL_3,user);
    }
   
    deleteUser(userId){
        return axios.delete(USER_URL_4 + '/' + userId);
    }
   
}

export default new UserService()






