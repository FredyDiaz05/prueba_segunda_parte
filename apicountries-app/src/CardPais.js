import React from 'react'

export const CardPais = ({id,Bandera,name,region,subregion}) => {
    return (

        <div>
            <h1 >{name}</h1>
           <img src= {Bandera} height = "100"></img> 
           <h2>{region}</h2>
           <p>{subregion}</p>
        </div>
    )
}
