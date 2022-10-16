import React, { Component } from 'react'
import UserService from '../services/UserService';
import {Link} from 'react-router-dom';

class CreateUserComponent extends Component {
    constructor(props){
        super(props)

        this.state={
            userName:''
        }
        this.changeNameHandler = this.changeNameHandler.bind(this);
        this.saveUser = this.saveUser.bind(this);
    }
    saveUser = (e) => {
        let user = {userName: this.state.userName};
        console.log('user => ' + JSON.stringify(user));

        UserService.createUser(user).then(res =>{      
         
        });
        
    }
    changeNameHandler = (event) => {
        this.setState({userName: event.target.value});
    }

    
    render() {
        return (
            <div>
                <div className="container">
                    <div className="row">
                        <div className="card col-md-6 offset-md-3 offset-md-3">
                            <h3 className="text-center">New User</h3>
                            <div className = "card-body">
                                <form>
                                         <div className = "form-group">
                                            <label> Name </label>
                                            <input placeholder="Name" name="userName" className="form-control" 
                                                value={this.state.userName} onChange={this.changeNameHandler}/>
                                        </div>

                                        <Link to= "/getUsers" onClick={this.saveUser} className="btn btn-primary mb-2">Add User</Link>
                                      
                                        
                                </form>
                            </div>

                        </div>

                    </div>
                </div>
            </div>
        )
    }
}

export default CreateUserComponent