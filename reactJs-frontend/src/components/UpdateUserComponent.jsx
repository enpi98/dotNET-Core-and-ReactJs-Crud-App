import React, { Component } from 'react'
import UserService from '../services/UserService';
import {Link} from 'react-router-dom';

class UpdateUserComponent extends Component {
   
    constructor(props){
       
        super(props)
        
        this.state={
            id:this.props.router.params.id,
            userName:'' 
        }
        this.changeNameHandler = this.changeNameHandler.bind(this);
        this.updateUser = this.updateUser.bind(this); 
    }
     componentDidMount(){
        
        UserService.getUserById(this.state.id).then((res)=>{
            let user = res.data;
            this.setState({userName: user.userName });
        });
    }
     updateUser = (e) => { 
        let user = {userName: this.state.userName,id: this.state.id};
       
        UserService.updateUser(user).then(res=>{
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
                            <h3 className="text-center">Update User</h3>
                            <div className = "card-body">
                                <form>
                                         <div className = "form-group">
                                            <label> Name </label>
                                            <input placeholder="Name" name="userName" className="form-control" 
                                                value={this.state.userName} onChange={this.changeNameHandler}/>
                                        </div>
                                        
                                        <Link to= "/getUsers" onClick={this.updateUser} className="btn btn-primary mb-2">
                                        Update User</Link>
                                        
                                </form>
                            </div>

                        </div>

                    </div>
                </div>
            </div>
        )
    }
}

export default UpdateUserComponent;